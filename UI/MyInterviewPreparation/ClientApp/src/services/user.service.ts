import axios from "axios";
import { UserSetting } from "../Entities/UserSetting";

const API_URL = process.env.REACT_APP_BaseQAURL + "/api/QuestionAnswer/";

const configHeaders = {
  "content-type": "application/json",
  "Accept": "application/json"
};

export const SaveUserSetting = (userSetting: UserSetting) => {
  return axios

    .post(
      API_URL + "SaveUserSetting",
      userSetting,
    )
    .then((response: any) => {
      console.log(response);
      
      return response.data;
    });
};


