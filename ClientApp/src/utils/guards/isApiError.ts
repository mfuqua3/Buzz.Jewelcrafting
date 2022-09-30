import {ApiError} from "../../domain/models/ApiError";

export function isApiError(candidate: object): candidate is ApiError {
    return "status" in candidate && "statusCode" in candidate && "message" in candidate;
}
