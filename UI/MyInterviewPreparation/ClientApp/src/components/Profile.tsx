import React from "react";
import { getCurrentUser } from "../services/auth.service";

const Profile: React.FC = () => {
  const currentUser = getCurrentUser();

  return (
    <div className="container">
      <header className="jumbotron">
        <h3>
          <strong>{currentUser?.email}</strong> Profile
        </h3>
      </header>
     
      <p>
        <strong>Id:</strong> {currentUser?.id}
      </p>
      <p>
        <strong>Email:</strong> {currentUser?.email}
      </p>
      <strong>Authorities:</strong>

    </div>
  );
};

export default Profile;
