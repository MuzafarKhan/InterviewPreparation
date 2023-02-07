import React, { useEffect, useState } from "react";
import Accordion from "react-bootstrap/Accordion";
import { NavigateFunction, useLocation, useNavigate } from "react-router-dom";
import { getCurrentUser } from "../services/auth.service";
import { GetAllUserQuestionAnswerByDomainId, GetRandomQuestionAnswerByDomainId } from "../services/questionanswer.service";
import { UserQuestionAnswer } from "../Entities/UserQuestionAnswer";
import { Editor } from "react-draft-wysiwyg";
import "react-draft-wysiwyg/dist/react-draft-wysiwyg.css";
import { EditorState, ContentState, convertFromHTML, convertToRaw } from "draft-js";
import draftToHtml from "draftjs-to-html";
import draftToMarkdown from "draftjs-to-html";

import { QuestionAnswerStatus } from "../Entities/Enums";
import ProgressBar from "react-bootstrap/esm/ProgressBar";

const StartTest: React.FC = () => {
  let navigate: NavigateFunction = useNavigate();
  const location = useLocation();
  const domainId = location?.state?.domainId;
  const [qanswer, setAnswer] = useState<string>("");
  const [questionId, setquestionId] = useState<number>();
  const [question, setQuestion] = useState<string>("");
  const [prepairedRatio, setPrepairedRatio] = useState<number>(0);
  const [questionAnswers, setQuestionAnswers] = useState();

  useEffect(() => initGetRandomQuestionAnswerByDomainId(), []);

  const initGetRandomQuestionAnswerByDomainId = () => {
    GetRandomQuestionAnswerByDomainId(domainId).then(
      (response) => {
        setQuestion(response.question);
        setAnswer(response.answer);
        setquestionId(response.id as number);
        setPrepairedRatio((response.prepairedRatio as number)*10);
        
      },
      (error) => {
        const resMessage =
          (error.response &&
            error.response.data &&
            error.response.data.message) ||
          error.message ||
          error.toString();
      }
    );
  }

  const handleEditQuestion = (questionId: number| undefined) => {
    navigate("/EditQuestion", { state: { id: questionId as number } });
  }

  const handleNotPrepaird = () => {
    initGetRandomQuestionAnswerByDomainId();
  }

  const handlePrepaird = (questionId: number| undefined) => {
    //navigate("/EditQuestion", { state: { id: questionId as number } });
  }

  return (
    <div>
      <ProgressBar now={prepairedRatio} label={prepairedRatio} variant={prepairedRatio < 70 ? prepairedRatio < 40 ? "danger": "info" : "success"} />
      <Accordion defaultActiveKey="0" className="mt-2">
        <Accordion.Item color='red' eventKey={question}>
          <Accordion.Header color='red'>{question}</Accordion.Header>
          <Accordion.Body color='red'>
            <div className="bg-light" onClick={() => handleEditQuestion(questionId)} dangerouslySetInnerHTML={{ __html: qanswer }} />
            <div className="form-group panel-body mt-3">
              <button type="submit" onClick={() => handleNotPrepaird()} className="btn btn-danger previous">Not Prepaird</button>
              <button type="submit" onClick={() => handlePrepaird(questionId)} className="btn btn-success float-right">Prepaird</button>
            </div>
          </Accordion.Body>
        </Accordion.Item>
      </Accordion>


    </div>

  );
};

export default StartTest;




