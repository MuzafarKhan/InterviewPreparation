import React, { useState } from "react";
import { NavigateFunction, useNavigate } from 'react-router-dom';
import { SubjectStatus } from "../Entities/Enums";
import { UserSubject } from "../Entities/UserSubject";
import { SaveUserSubject } from "../services/questionanswer.service";


import { SaveUserSetting } from "../services/user.service";


type Props = {}

const AddNewSubject: React.FC<Props> = () => {
  let navigate: NavigateFunction = useNavigate();
  const [subjectName, setSubjectName] = useState<string>("");

  const handleChange = (e: any)=>{
debugger;
  }

  const handleSaveUserSubject = (subjectId: number) => {


    let userSubject: UserSubject =
    {
      baseURL: "",
      "methodName": "",
      id: 0,
      name: subjectName,
      createdDate: null,
      updatedDate: null,
      subjectStatus: SubjectStatus.Active,
      userId: 7,
      systemSubjectId: null,
      domainCount: null,
    }
debugger;

    SaveUserSubject(userSubject).then(

      () => {
        debugger;
        navigate(`/AllSubjects`);
        window.location.reload();
        debugger;
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
  };

  return (
    <div className="col-md-12">

      <div className="form-group">
        <input type="text" className="form-control" id="subjectName" aria-describedby="emailHelp" placeholder="Enter Subject Name" onChange={(e) => {setSubjectName(e.target.value)}} />
      </div>


      <button type="submit" className="btn btn-primary mt-2" onClick={() => handleSaveUserSubject(1)}>Submit</button>


    </div>
  );
};

export default AddNewSubject;
