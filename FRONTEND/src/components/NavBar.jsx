import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import { RoutesNames } from '../constants';
import { useNavigate } from 'react-router-dom';



export default function NavBar(){

    const navigate = useNavigate();

    return(
        <>
            <Navbar collapseOnSelect expand="lg" className="bg-body-tertiary">
      <Container>
        <Navbar.Brand 
        className='kursor'
        onClick={() => navigate(RoutesNames.HOME)}
        >Edunova APP</Navbar.Brand>
        <Navbar.Toggle aria-controls="responsive-navbar-nav" />
        <Navbar.Collapse id="responsive-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="https://srdjan294-001-site1.anytempurl.com/"
            target='_blank'>API</Nav.Link>
            
            <NavDropdown title="Programi" id="collapsible-nav-dropdown">
              <NavDropdown.Item href="#action/3.1">Smjerovi</NavDropdown.Item>
              <NavDropdown.Item href="#action/3.2">
                Polaznici
              </NavDropdown.Item>
              <NavDropdown.Item href="#action/3.3">Predavači</NavDropdown.Item>
              
              <NavDropdown.Item href="#action/3.4">
                Grupe
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>
          
        </Navbar.Collapse>
      </Container>
    </Navbar>
  
        </>
    );
}