import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Form from 'react-bootstrap/Form';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import Offcanvas from 'react-bootstrap/Offcanvas';
import "bootstrap/dist/css/bootstrap.min.css";
import { Link, NavigateFunction, Route, Routes, useNavigate } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faArrowLeft, faBackspace, faHome } from '@fortawesome/free-solid-svg-icons';
import { useEffect, useState } from 'react';
import EventBus from './common/EventBus';
import * as AuthService from "./services/auth.service";
import { UserInfo } from './Entities/UserInfo';
import Restore from '@mui/icons-material/Restore';
import RoofingIcon from '@mui/icons-material/Roofing';

import Login from "./components/Login";
import Register from "./components/Register";
import Home from "./components/Home";
import Profile from "./components/Profile";
import BoardUser from "./components/BoardUser";
import BoardModerator from "./components/BoardModerator";
import BoardAdmin from "./components/BoardAdmin";
import AllQuestions from "./components/AllQuestions";
import AllDomains from "./components/AllDomains";
import AllSubjects from "./components/AllSubjects";
import SetUserSettings from "./components/SetUserSettings";
import EditQuestion from "./components/EditQuestion";
import AddNewSubject from "./components/AddNewSubject";
import StartTest from "./components/StartTest";
import { debug } from 'console';
import { BottomNavigation, BottomNavigationAction } from '@mui/material';
import "./App.css";
import { Back } from 'react-bootstrap-icons';
import { KeyboardBackspace } from '@mui/icons-material';

const App: React.FC = () => {
  const [currentUser, setCurrentUser] = useState<UserInfo | undefined>(undefined);
  let navigate: NavigateFunction = useNavigate();
  let disabledBack = window.location.pathname == "/AllDomains" && !window.location.search;
  let expand = false;
  useEffect(() => {
    const user = AuthService.getCurrentUser();
    if (user) {
      setCurrentUser(user);
      //setShowModeratorBoard(user.roles.includes("ROLE_MODERATOR"));
      //setShowAdminBoard(user.roles.includes("ROLE_ADMIN"));
    }

    EventBus.on("logout", logOut);

    return () => {
      EventBus.remove("logout", logOut);
    };
  }, []);

  const logOut = () => {
    setCurrentUser(undefined);
    AuthService.logout();
    setCurrentUser(undefined);
  };




  return (
    <>
      {currentUser && <div>

        <div className="w-100 mt-0">
          <Navbar key={expand.toString()} bg="light" expand={expand}>
            <Container fluid>
  
              <Link to={"/AllDomains"} className="navbar-brand text-center">
                <FontAwesomeIcon icon={faHome} color="black" size="lg" />
              </Link>
              <Navbar.Toggle aria-controls={`offcanvasNavbar-expand-${expand}`} >
                <img src='https://ui-avatars.com/api/size=32?rounded=true?name=Muzafar+Khan'></img>
              </Navbar.Toggle>
              <Navbar.Offcanvas
                id={`offcanvasNavbar-expand-${expand}`}
                aria-labelledby={`offcanvasNavbarLabel-expand-${expand}`}
                placement="end"
              >
                <Offcanvas.Header closeButton>
                  <Offcanvas.Title id={`offcanvasNavbarLabel-expand-${expand}`}>

                  </Offcanvas.Title>
                </Offcanvas.Header>
                <Offcanvas.Body>
                  <Nav className="justify-content-end flex-grow-1 pe-3">

                    <Link to={"/AllDomains?NeedToStartTest=true"} className="nav-link">
                      Start Test
                    </Link>


                    <Link to={"/SetUserSettings"} className="nav-link">
                      Settings
                    </Link>

                    <NavDropdown
                      title="Add New "
                      id={`offcanvasNavbarDropdown-expand-${expand}`}
                    >

                      <Link to={"/AddNewSubject"} className="nav-link">
                        Subject
                      </Link>


                      <Link to={"/AddNewSubject"} className="nav-link">
                        Question
                      </Link>


                    </NavDropdown>


                    <Link to={""} onClick={logOut} className="nav-link">
                      logOut
                    </Link>

                  </Nav>
                  <Form className="d-flex mt-1">
                    <Form.Control
                      type="search"
                      placeholder="Search"
                      className="me-2"
                      aria-label="Search"
                    />
                    <Button variant="outline-success">Search</Button>
                  </Form>
                </Offcanvas.Body>
              </Navbar.Offcanvas>
            </Container>
          </Navbar>
        </div>



        <div className="container mt-2 overflow-auto height-600px">
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/home" element={<Home />} />
            <Route path="/register" element={<Register />} />
            <Route path="/profile" element={<Profile />} />
            <Route path="/allQuestions" element={<AllQuestions />} />
            <Route path="/allDomains" element={<AllDomains />} />
            <Route path="/allSubjects" element={<AllSubjects />} />
            <Route path="/user" element={<BoardUser />} />
            <Route path="/mod" element={<BoardModerator />} />
            <Route path="/admin" element={<BoardAdmin />} />
            <Route path="/SetUserSettings" element={<SetUserSettings />} />
            <Route path="/EditQuestion" element={<EditQuestion />} />
            <Route path="/AddNewSubject" element={<AddNewSubject />} />
            <Route path="/StartTest" element={<StartTest />} />


          </Routes>

        </div>
        <BottomNavigation
          showLabels
          value={"selected"}
          onChange={(event, newValue) => {
            //setValue(newValue);
          }}
        >
          <BottomNavigationAction onClick={() => navigate(-1)} value={!disabledBack? "selected":"not-selected"} 
            label="Back" disabled={disabledBack} icon={<KeyboardBackspace />} />
          <BottomNavigationAction onClick={() => navigate("AllDomains")} value="selected" label="Home" icon={<RoofingIcon />} />
          <BottomNavigationAction onClick={() => navigate("AllDomains?NeedToStartTest=true")} value="selected" label="Start test" icon={<Restore />} />

        </BottomNavigation>

      </div>
      }

      <Routes>
        <Route path="/login" element={<Login />} />
      </Routes>
    </>
  );
}

export default App;