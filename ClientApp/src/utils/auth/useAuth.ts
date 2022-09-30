import React from "react";
import {AuthContext} from "./AuthProvider";

export function useAuth() {
    const auth = React.useContext(AuthContext);
    if(auth === null) throw Error("No Auth Provider");
    return auth;
}