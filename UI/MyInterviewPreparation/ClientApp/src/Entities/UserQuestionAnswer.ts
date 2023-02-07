import { QuestionAnswerStatus } from "./Enums";
import { BaseRequest } from "./BaseRequest";

export interface UserQuestionAnswer extends BaseRequest{
    id: number;
    createdDate: string | null;
    updatedDate: string | null;
    question: string ;
    answer: string ;
    domainId: number ;
    userId: number ;
    questionAnswerStatus: QuestionAnswerStatus;
    useFullLink: string;
    prepairedRatio: number | null;
    systemQuestionAnswerId: number | null;
}