import axios from "axios";
import { UserInfo } from "../Entities/UserInfo";

const API_URL = "https://localhost:4579/api/Auth/";

export const register = (email: string, password: string) => {
  return axios
    .post(API_URL + "RegisterUser", {
      BaseURL: "abc",
      MethodName: "abc",
      email,
      password,
    })
    .then((response: any) => {
      console.log(response);

      if (response.data) {
        localStorage.setItem("user", JSON.stringify(response.data));
        localStorage.setItem(
          "accessToken",
          JSON.stringify(response.accessToken)
        );
      }

      return response.data;
    });
};

const configHeaders = {
  "content-type": "application/json",
  "Accept": "application/json"
};

export const login = (userInfo: UserInfo) => {
  return axios

    .post(
      API_URL + "CreateToken",
      userInfo,
    )
    .then((response: any) => {
        console.log(response);
      if (response.data) {
        localStorage.setItem("user", response.data.data);
      }
      console.log("asdas");

      return response.data;
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
