import { DomainStatus } from "./Enums";

export interface UserDomain {
    id: number;
    createdDate: string | null;
    updatedDate: string | null;
    name: string;
    domainStatus: DomainStatus;
    subjectId: number | null;
    systemDomainId: number | null;
    questionAnswerCount: number;
}