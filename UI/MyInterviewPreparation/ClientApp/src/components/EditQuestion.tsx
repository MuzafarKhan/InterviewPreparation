import React, { useEffect, useState } from "react";
import Accordion from "react-bootstrap/Accordion";
import { Form, NavigateFunction, useLocation, useNavigate } from "react-router-dom";
import { getCurrentUser } from "../services/auth.service";
import { GetAllUserQuestionAnswerByDomainId, GetUserQuestionAnswerById, SaveUserQuestionAnswerById } from "../services/questionanswer.service";
import { UserQuestionAnswer } from "../Entities/UserQuestionAnswer";
import { Editor } from "react-draft-wysiwyg";
import "react-draft-wysiwyg/dist/react-draft-wysiwyg.css";
import { EditorState, ContentState, convertFromHTML, convertToRaw } from "draft-js";
import draftToHtml from "draftjs-to-html";
import { ErrorMessage, Field, Formik } from "formik";
import { QuestionAnswerStatus } from "../Entities/Enums";
import * as Yup from "yup";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faSave, faSignOut, faUser } from "@fortawesome/free-solid-svg-icons";
import { Button } from "react-bootstrap";
import * as Icon from 'react-bootstrap-icons';
import JoditEditor from "jodit-react";

const EditQuestion: React.FC = () => {
  /*const currentUser = getCurrentUser();*/

  let navigate: NavigateFunction = useNavigate();
  const [qanswer, setAnswer] = useState<string>("");
  const [question, setQuestion] = useState<string>("");
  const location = useLocation();
  const questionId = location.state.id;


  const initialValues: {
    id: number;
    createdDate: string | null;
    updatedDate: string | null;
    question: string;
    answer: string;
    domainId: number | null;
    userId: number | null;
    questionAnswerStatus: QuestionAnswerStatus;
    useFullLink: string;
    prepairedRatio: number | null;
    systemQuestionAnswerId: number | null;
  } = {
    id: questionId,
    createdDate: "",
    updatedDate: "",
    question: "",
    answer: "",
    domainId: 0,
    userId: 0,
    questionAnswerStatus: QuestionAnswerStatus.Active,
    useFullLink: "",
    prepairedRatio: 0,
    systemQuestionAnswerId: 0,
  };

 
  useEffect(() => initGetUserQuestionAnswerById(), []);


  const initGetUserQuestionAnswerById = () => {
    GetUserQuestionAnswerById(questionId).then(
      (response) => {
        setQuestion(response.question);
        setAnswer(response.answer);
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

  
  const handleSaveUserQuestionAnswerById = (formValue: { id: number; }) => {
    let userQuestionAnswer = 
      {
        baseURL: "",
        "methodName": "",
        "id": questionId as number,
        question: question,
        answer: qanswer,
        createdDate: null,
        updatedDate: null,
        domainId: 0,
        userId: 0,
        questionAnswerStatus: QuestionAnswerStatus.Active,
        useFullLink: "",
        prepairedRatio: null,
        systemQuestionAnswerId: null
      } ;

    SaveUserQuestionAnswerById(userQuestionAnswer).then(
      (response) => {
       navigate(`/AllDomains`);
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

  const onContentChange = (answers: string) => {
    setAnswer(answers);
  }


  return (
    <div>
      
      <div><h1>{question}
      </h1>
        <div className="row">
          <div>
            <FontAwesomeIcon icon={faSave} color="green" size="4x" pull="right"  style={{cursor: "pointer"}} onClick={()=>handleSaveUserQuestionAnswerById(questionId)}/>
          </div>
        </div>
 
      </div>
      <div className="mt-4">
      <JoditEditor
        //ref={editor}
        value={qanswer}
        //config={config}
        //tabIndex={1} // tabIndex of textarea
         onBlur={(newContent) => setAnswer(newContent)}
        onChange={onContentChange}
		/>
      </div>
    </div>
  );
};

export default EditQuestion;


