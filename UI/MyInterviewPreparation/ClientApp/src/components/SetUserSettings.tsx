import React, { useState } from "react";
import { NavigateFunction, useNavigate } from 'react-router-dom';
import { Formik, Field, Form, ErrorMessage } from "formik";
import * as Yup from "yup";

import { SaveUserSetting } from "../services/user.service";


type Props = {}

const SetUserSettings: React.FC<Props> = () => {
  let navigate: NavigateFunction = useNavigate();

  const [loading, setLoading] = useState<boolean>(false);
  const [message, setMessage] = useState<string>("");

  const initialValues: {
    subjectId: number;
    userId: number;
    id: number;
  } = {
    subjectId: 0,
    id: 0,
    userId: 0,
  };

  const validationSchema = Yup.object().shape({
    subjectId: Yup.number().required("This field is required!"),
  });

  const handleSaveUserSetting = (formValue: { subjectId: number; }) => {

    setMessage("");
    setLoading(true);

    let UserSetting =
    {
      baseURL: "",
      "methodName": "",
      "id": 0,
      "subjectId": formValue.subjectId as number,
      "userId": 7,
    }


    SaveUserSetting(UserSetting).then(

      () => {
        debugger;
        navigate(`/AllDomains`, { state: { id: UserSetting.subjectId as number } });
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

        setLoading(false);
        setMessage(resMessage);
      }
    );
  };

  return (
    <div className="col-md-12">
      <Formik
        initialValues={initialValues}
        validationSchema={validationSchema}
        onSubmit={handleSaveUserSetting}
      >
        <Form>
          <div className="form-group">
            <label htmlFor="subjectId">Select Subject:</label>
            <Field as="select" name="subjectId" className="form-select" >
              <option value="108">Computer Science</option>
              <option value="109">Medical Science</option>
              <option value="111">Electronics</option>
            </Field>
            <ErrorMessage
              name="subjectId"
              component="div"
              className="alert alert-danger"
            />
          </div>

          <div className="form-group mt-2">
            <button type="submit" className="btn btn-primary btn-block" disabled={loading}>
              {loading && (
                <span className="spinner-border spinner-border-sm"></span>
              )}
              <span>Save Settings</span>
            </button>
          </div>

          {message && (
            <div className="form-group">
              <div className="alert alert-danger" role="alert">
                {message}
              </div>
            </div>
          )}
        </Form>
      </Formik>
    </div>
  );
};

export default SetUserSettings;
