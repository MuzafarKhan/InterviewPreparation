import React, { useEffect, useState } from "react";
import Button from "react-bootstrap/Button";
import Badge from "react-bootstrap/Badge";
import Row from "react-bootstrap/Row";
import { NavigateFunction, useNavigate, useLocation, useSearchParams } from "react-router-dom";
import { UserDomain } from "../Entities/UserDomain";
import { GetAllUserDomainBySubjectId } from "../services/questionanswer.service";
import { getCurrentUser } from "../services/auth.service";

const AllDomains: React.FC = () => {
  let navigate: NavigateFunction = useNavigate();
  const location = useLocation();
  const subjectId = location?.state?.id??getCurrentUser()?.userSubjectId;
  const [isLoading, setLoading] = useState(false);
  const [domains, setDomain] = useState([]);
  const [searchParams, setSearchParams] = useSearchParams();
  let NeedToStartTest = searchParams.get("NeedToStartTest") == "true";
  
  useEffect(() => initGetAllUserDomainBySubjectId(), []);

  const initGetAllUserDomainBySubjectId = () => {
    GetAllUserDomainBySubjectId(subjectId).then(
      (response) => {
        setDomain(response);
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

  const handleClick = (domainId: number) => {
    setLoading(true);
    if(NeedToStartTest){
      navigate(`/StartTest`,{state:{domainId:domainId}});
    }
    else{
    navigate(`/AllQuestions`,{state:{id:domainId}});
    }
  };

  return (
    <div style={{ textAlign: "center" }}>
      <h1> Please Select Domain</h1>
      {domains &&
        domains.map((domain: UserDomain) => (
          <Row key={domain.id} className="mb-3">
            <Button
              variant="primary"
              disabled={isLoading}
              onClick={!isLoading ? () => handleClick (domain.id): undefined}
            >
              {isLoading ? "Loading…" : domain.name}
              <Badge bg="secondary">{domain.questionAnswerCount}</Badge>
              <span className="visually-hidden">unread messages</span>
            </Button>
          </Row>
        ))}
    </div>
  );
};

export default AllDomains;
