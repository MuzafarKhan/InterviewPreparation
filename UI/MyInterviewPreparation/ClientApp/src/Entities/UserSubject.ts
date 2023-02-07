import { BaseRequest } from "./BaseRequest";
import { SubjectStatus } from "./Enums";

export interface UserSubject extends BaseRequest {
    id: number;
    name: string;
    createdDate: string | null;
    updatedDate: string | null;
    subjectStatus: SubjectStatus;
    userId: number;
    systemSubjectId: number | null;
    domainCount: number | null;
}