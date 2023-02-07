import React, { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import Badge from "react-bootstrap/Badge";
import Row from "react-bootstrap/Row";
import { NavigateFunction, useNavigate } from "react-router-dom";

import { GetAllUserSubjectByUserId } from "../services/questionanswer.service";
import {UserSubject} from '../Entities/UserSubject'

const AllSubjects: React.FC = () => {
  let navigate: NavigateFunction = useNavigate();

  const [isLoading, setLoading] = useState(false);
  const [subjects, setSubjects] = useState([]);

  const handleClick = (subjectId : number ) => {
    setLoading(true);
    navigate(`/AllDomains`,{state:{id:subjectId}});
  };

  useEffect(() => initGetAllUserSubjectByUserId(), []);

  const initGetAllUserSubjectByUserId = () => {
    GetAllUserSubjectByUserId(7).then(
      (response) => {
        setSubjects(response);
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

  return (
    <div style={{ textAlign: "center" }}>
      <h1> Please Select Subject </h1>
      
      {subjects  &&
        subjects.map((subject: UserSubject) => (
          <Row key={subject.id} className="mb-3">
            <Button
              variant="primary"
              disabled={isLoading}
              onClick={!isLoading ? () => handleClick(subject.id) : undefined}
            >
              {isLoading ? "Loading…" : subject.name}
              <Badge bg="secondary">{subject.domainCount}</Badge>
              <span className="visually-hidden">unread messages</span>
            </Button>
          </Row>
        ))}
    </div>
  );
};

export default AllSubjects;
