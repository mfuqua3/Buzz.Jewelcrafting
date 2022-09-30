import React from "react";
import {createRoot} from 'react-dom/client';
import {BrowserRouter} from "react-router-dom";
import App from "./App";
import * as serviceWorkerRegistration from "./serviceWorkerRegistration";
import {CssBaseline, ThemeProvider} from "@mui/material";
import {defaultTheme} from "./themes/defaultTheme";
import AdapterMoment from "@date-io/moment";
import {SnackbarProvider} from "./utils/snackbar";
import ModalProvider from "./utils/modal/ModalProvider";
import {LocalizationProvider} from "@mui/x-date-pickers";
import DrawerProvider from "./utils/drawer/DrawerProvider";
import AuthProvider from "./utils/auth/AuthProvider";

const baseUrl = document.getElementsByTagName("base")[0].getAttribute("href");
const rootElement = document.getElementById("root");
// eslint-disable-next-line @typescript-eslint/no-non-null-assertion
const root = createRoot(rootElement!);
root.render(
    <React.StrictMode>
        <LocalizationProvider dateAdapter={AdapterMoment}>
            <ThemeProvider theme={defaultTheme}>
                <CssBaseline/>
                <BrowserRouter basename={baseUrl ?? undefined}>
                    <AuthProvider>
                        <SnackbarProvider>
                            <ModalProvider>
                                <DrawerProvider>
                                    <App/>
                                </DrawerProvider>
                            </ModalProvider>
                        </SnackbarProvider>
                    </AuthProvider>
                </BrowserRouter>
            </ThemeProvider>
        </LocalizationProvider>
    </React.StrictMode>
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://cra.link/PWA
serviceWorkerRegistration.unregister();
