import {GemCutItem} from "./GemCutItem";
import {JewelryItem} from "./JewelryItem";
import {UserStatus} from "./UserStatus";

export interface DesignStatus {
    gemCuts: GemCutItem[];
    jewelry: JewelryItem[];
    userStatusList: UserStatus[];
}