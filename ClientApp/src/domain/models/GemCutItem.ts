import {DesignItem} from "./DesignItem";

export interface GemCutItem extends DesignItem{
    stat1?: string;
    stat2?: string;
    color: GemColor;
}

export type GemColor = "Meta" | "Red" | "Blue" | "Yellow" | "Orange" | "Green" | "Purple"