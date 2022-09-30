import {User} from "../../domain/models/User";

export interface AuthState {
    isAuthenticated: boolean;
    loading: boolean;
    user: User | null;
    loginRedirect(redirectUrl: string): void;
}