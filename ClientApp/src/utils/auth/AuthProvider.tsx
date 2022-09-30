import React, {ReactNode, useEffect, useState} from "react";
import {AuthState} from "./AuthState";
import axios from "axios";
import {User} from "../../domain/models/User";
import {isAxiosError} from "../guards";

export const AuthContext = React.createContext<AuthState | null>(null);
const apiRoot = process.env.REACT_APP_API_ROOT;

function AuthProvider({children}: { children: ReactNode }) {
    const [authState, setAuthState] = useState<Omit<AuthState, "loginRedirect">>({
        loading: true,
        isAuthenticated: false,
        user: null
    });
    useEffect(() => {
        initializeProvider()
            .catch(console.error);
    },[])

    async function initializeProvider() {
        try {
            const user = await axios.get<User>(`${apiRoot}/api/users/me`, {withCredentials: true});
            setAuthState({loading: false, isAuthenticated: true, user: user.data});
            return;
        } catch (e) {
            setAuthState({loading: false, isAuthenticated: false, user: null});
            if (isAxiosError(e)) {
                if (e.code === "401") {
                    return;
                }
            }
            console.error(e);
        }
    }

    function loginRedirect(redirectUrl: string) {
        const redirect = encodeURI(redirectUrl);
        window.location.href = `${apiRoot}/authorize?redirectUrl=${redirect}`;
    }

    return (
        <AuthContext.Provider value={{...authState, loginRedirect}}>
            {children}
        </AuthContext.Provider>
    )
}

export default React.memo(AuthProvider);