import React, { useEffect, useState } from "react";
import Accordion from "react-bootstrap/Accordion";
import { NavigateFunction, useLocation, useNavigate } from "react-router-dom";
import { getCurrentUser } from "../services/auth.service";
import { GetAllUserQuestionAnswerByDomainId } from "../services/questionanswer.service";
import { UserQuestionAnswer } from "../Entities/UserQuestionAnswer";
import { Editor } from "react-draft-wysiwyg";
import "react-draft-wysiwyg/dist/react-draft-wysiwyg.css";
import { EditorState, ContentState, convertFromHTML, convertToRaw } from "draft-js";
import draftToHtml from "draftjs-to-html";
import draftToMarkdown from "draftjs-to-html";

import { QuestionAnswerStatus } from "../Entities/Enums";

const AllQuestions: React.FC = () => {
  /*const currentUser = getCurrentUser();*/
  let navigate: NavigateFunction = useNavigate();

  const location = useLocation();
  const domainId = location.state.id;
  const [questionAnswers, setQuestionAnswers] = useState([]);

  useEffect(() => initGetAllUserQuestionAnswerByDomainId(), []);

  const initGetAllUserQuestionAnswerByDomainId = () => {
    GetAllUserQuestionAnswerByDomainId(domainId).then(
      (response) => {
        setQuestionAnswers(response);
        //createScript(response);
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

  const handleEditQuestion = (questionId: number) => {
    navigate("/EditQuestion", { state: { id: questionId as number } });
  }
  return (
    <Accordion defaultActiveKey="0">
      {questionAnswers &&
        questionAnswers.map((question: UserQuestionAnswer) => (
          <Accordion.Item color='red' key={question.id} eventKey={question.id.toString()}>
            <Accordion.Header color='red'>{question.question}</Accordion.Header>
            <Accordion.Body onClick={() => handleEditQuestion(question.id)} color='red'>
            
              <div dangerouslySetInnerHTML={{__html: question.answer}} />
            </Accordion.Body>
          </Accordion.Item>
        ))}
    </Accordion>
  );
};

export default AllQuestions;


function stateToHTML(arg0: ContentState) {
  throw new Error("Function not implemented.");
}



