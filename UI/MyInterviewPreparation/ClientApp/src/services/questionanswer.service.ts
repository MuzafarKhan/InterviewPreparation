import axios from "axios";
import { UserInfo } from "../Entities/UserInfo";
import { UserQuestionAnswer } from "../Entities/UserQuestionAnswer";
import { UserSubject } from "../Entities/UserSubject";

const API_URL = "https://localhost:4579/api/QuestionAnswer/";

export const GetAllUserDomainBySubjectId = (subjectId: number) => {
  return axios
    .get(API_URL + "GetAllUserDomainBySubjectId", {
      params: {
        subjectId,
      }
    })
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const GetAllUserQuestionAnswerByUserId = (userId: number) => {
  return axios
    .get(API_URL + "GetAllUserQuestionAnswerByUserId", {
      params: {
        userId,
      }
    })
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const GetAllUserQuestionAnswerByDomainId = (domainId: number) => {
  return axios
    .get(API_URL + "GetAllUserQuestionAnswerByDomainId", {
      params: {
        domainId,
      }
    })
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const GetAllUserSubjectByUserId = (userId: number) => {
  return axios
    .get(API_URL + "GetAllUserSubjectByUserId", {
      params: {
        userId,
      }
    })
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const GetUserQuestionAnswerById = (id: number) => {
  return axios
    .get(API_URL + "GetUserQuestionAnswerById", {
      params: {
        id,
      }
    })
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const GetRandomQuestionAnswerByDomainId = (domainId: number) => {
  return axios
    .get(API_URL + "GetRandomQuestionAnswerByDomainId", {
      params: {
        domainId,
      }
    })
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};


export const SaveUserQuestionAnswerById = (userQuestionAnswer: UserQuestionAnswer) => {
  return axios
    .post(API_URL + "SaveUserQuestionAnswerById", 
      userQuestionAnswer,
    )
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const SaveUserSubject = (userSubject: UserSubject) => {
  return axios
    .post(API_URL + "SaveUserSubject", 
      userSubject,
    )
    .then((response: any) => {
      return JSON.parse(response.data.data).payload;
    });
};

export const register = (email: string, password: string) => {

  return axios.post(API_URL + "RegisterUser", {
    BaseURL: "abc",
    MethodName: "abc",
    email,
    password,

  }).then((response: any) => {
    console.log(response);

    if (response.data) {
      localStorage.setItem("user", JSON.stringify(response.data));
      localStorage.setItem("accessToken", JSON.stringify(response.accessToken));
    }

    return JSON.parse(response.data.data).payload;
  });
};



export const logout = () => {
  localStorage.removeItem("user");
  window.location.href = "login";
};

export const getCurrentUser = () => {
  const userStr = localStorage.getItem("user");
  if (userStr) return JSON.parse(userStr)?.payload?.userInfo as UserInfo;

  return null;
};
