import { UserInfoStatus } from "./Enums";
import { BaseRequest } from "./BaseRequest";

export interface UserInfo extends BaseRequest {
    id: number;
    createdDate: string | null;
    updatedDate: string | null;
    email: string;
    password: string;
    salt: string;
    firstName: string;
    lastName: string;
    userInfoStatus: UserInfoStatus;
    mobileNumber: string;
    userSubjectId: number | 0;
}