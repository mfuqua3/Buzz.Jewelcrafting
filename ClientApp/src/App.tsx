import React, {useEffect, useState} from "react";
import ModalRoot from "./utils/modal/ModalRoot";
import SnackbarRoot from "./utils/snackbar/SnackbarRoot";
import {useAuth} from "./utils/auth/useAuth";
import CardPresentationLayout from "./components/Layouts/CardPresentationLayout";
import {DesignStatus} from "./domain/models/DesignStatus";
import axios from "axios";
import {
    Button,
    Stack,
    Table,
    TableBody,
    TableCell,
    TableContainer,
    TableHead,
    TableRow,
    Typography
} from "@mui/material";
import WowheadTooltip from "./components/UtilityWrappers/WowheadTooltip";
import ItemIcon from "./components/Icons/ItemIcon";
import PersonIcon from '@mui/icons-material/Person';
import HourglassEmptyIcon from '@mui/icons-material/HourglassEmpty';
import CheckIcon from '@mui/icons-material/Check';
import CloseIcon from '@mui/icons-material/Close';
import AuthWrapper from "./components/UtilityWrappers/AuthWrapper";
import {useModal} from "./utils/modal";
import ModalFormLayout from "./components/Layouts/ModalFormLayout";
import ModalLayout from "./components/Layouts/ModalLayout";

interface Column {
    id: string;
    label: string;
    minWidth?: number;
    align?: 'right';
    format?: (value: number) => string;
}
const apiRoot = process.env.REACT_APP_API_ROOT;
const dalaranToken = "inv_misc_gem_variety_01";
function App() {
    const {showModal, hideModal} = useModal("medium");
    const {user, isAuthenticated, loading, loginRedirect} = useAuth();
    const [status, setStatus] = useState<DesignStatus>();
    useEffect(()=>{
        init().catch(console.error);
    },[]);
    async function init(){
        const designState = await axios.get<DesignStatus>(`${apiRoot}/api/designs`);
        setStatus(designState.data);
    }
    async function onStatusUpdate(){
        hideModal();
        await init();
    }
    const jewelcrafterUser = isAuthenticated && status?.userStatusList.some(x=>x.userId === user?.id);
    return (
        <>
            <CardPresentationLayout title={"Buzz Jewelcrafting Tracker"}
                                    action={
                <Button disabled={jewelcrafterUser}
                onClick={()=>loginRedirect(window.location.origin)}>
                    Im a Jewelcrafter, add me to the list!
                </Button>
                                    }>
                {status &&
                <TableContainer>
                    <Table stickyHeader aria-label={"jewelcrafting-table"}>
                        <TableHead>
                            <TableRow>
                                <TableCell key={"character"}>
                                    <PersonIcon fontSize={"large"}/>
                                </TableCell>
                                {[...status.jewelry, ...status.gemCuts].map(j=>
                                    <TableCell key={j.itemId}  align={"center"}>
                                        <WowheadTooltip itemId={j.itemId}>
                                            <ItemIcon iconName={j.iconName} style={{height: "35px"}}/>
                                        </WowheadTooltip>
                                    </TableCell>)}
                            </TableRow>
                            <TableRow>
                                <TableCell></TableCell>
                                {[...status.jewelry, ...status.gemCuts].map(j=>
                                    <TableCell key={j.itemId + "name"} align={"center"}>
                                        {j.name}
                                    </TableCell>)}
                            </TableRow>
                            <TableRow>
                                <TableCell>Cost</TableCell>
                                {[...status.jewelry, ...status.gemCuts].map(j=>
                                    <TableCell key={j.itemId + "cost"} align={"center"}>
                                        <Typography>{j.cost} <ItemIcon iconName={dalaranToken} style={{height: "12px"}}/></Typography>
                                    </TableCell>)}
                            </TableRow>
                        </TableHead>
                        <TableBody>
                            {
                                status.userStatusList.map(userStatus=>
                                    <TableRow hover tabIndex={-1} key={userStatus.userId}>
                                        <TableCell>
                                            {userStatus.username}
                                        </TableCell>
                                        {[...status.jewelry, ...status.gemCuts].map(j=>
                                            <TableCell key={userStatus.userId + "." + j.itemId + "status"}
                                                       onClick={()=> showModal(
                                                           <ChangeStatusForm name={j.name}
                                                                             id={j.id}
                                                                             onStatusUpdate={onStatusUpdate}
                                                                             current={
                                                                                 userStatus.ownedItems.includes(j.designId) ? "Owned" :
                                                                                 userStatus.pendingItems.includes(j.designId) ? "Pending" :
                                                                                     "Unowned"

                                                                             } />
                                                       )}
                                                       align={"center"} sx={{
                                                           "&:hover": {
                                                               backgroundColor: "lightgrey",
                                                               cursor: "pointer"
                                                           }
                                            }}>
                                                {
                                                    userStatus.ownedItems.includes(j.designId) ?
                                                        <CheckIcon color={"success"} /> :
                                                        userStatus.pendingItems.includes(j.designId) ?
                                                            <HourglassEmptyIcon color={"warning"}/> :
                                                            <CloseIcon color={"error"} />

                                                }
                                            </TableCell>)}
                                    </TableRow>)
                            }
                        </TableBody>
                    </Table>
                </TableContainer>}
            </CardPresentationLayout>
            <SnackbarRoot/>
            <ModalRoot/>
        </>
    );
}

function ChangeStatusForm({name, current, onStatusUpdate, id}: {name: string, current: "Unowned" | "Pending" | "Owned", id: number, onStatusUpdate: ()=>void}) {
    const {loginRedirect, isAuthenticated} = useAuth();
    const {hideModal} = useModal();
    async function changeStatus(status: "Unowned" | "Pending" | "Owned"){
        await axios.patch(`${apiRoot}/api/designs/${id}`,{},{
            params: {status},
            withCredentials: true
        });
        onStatusUpdate();
    }
    return (
        <ModalLayout title={isAuthenticated ? `Change status for ${name}?` : "Jewelcrafter Actions"}>
            <AuthWrapper fallback={
                <Stack spacing={2}>
                    <Typography>You must be a jewelcrafter to change an items status.</Typography>
                    <Button variant={"contained"} color={"primary"}
                    onClick={
                        ()=>{
                         hideModal();
                         loginRedirect(window.location.origin);
                        }
                    }>
                        I am a jewelcrafter!
                    </Button>
                    <Button variant={"contained"} color={"secondary"} onClick={hideModal}>Oh, Nevermind</Button>
                </Stack>
            }>
                <Stack spacing={2}>
                    {
                        current === "Owned" &&
                        <Button onClick={()=>changeStatus("Unowned")}
                            color={"error"} variant={"contained"}>
                            I do not have this
                        </Button>
                    }
                    {
                        current === "Pending" &&
                        <Button onClick={()=>changeStatus("Unowned")}
                                color={"error"} variant={"contained"}>
                            I am no longer working towards this
                        </Button>
                    }
                    {
                        current === "Unowned" &&
                        <Button onClick={()=>changeStatus("Pending")}
                                color={"warning"} variant={"contained"}>
                            Im working towards this design
                        </Button>
                    }
                    {
                        current !== "Owned" &&
                        <Button onClick={()=>changeStatus("Owned")}
                               color={"success"} variant={"contained"}>
                            I have this design
                        </Button>
                    }
                </Stack>
            </AuthWrapper>
        </ModalLayout>
    )
}

export default App;
