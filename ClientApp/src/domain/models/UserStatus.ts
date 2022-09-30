export interface UserStatus {
    userId: string;
    username: string;
    pendingItems: number[];
    ownedItems: number[];
}