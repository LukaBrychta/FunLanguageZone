import React, { useState } from 'react';
import { Navbar, NavDropdown, Nav } from 'react-bootstrap';
import { Link, useNavigate } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';
import './NavBar.css';

const NavBar = ({ categories, onCategorySelect }) => {
    const [selectedCategory, setSelectedCategory] = useState('All categories');
    const navigate = useNavigate();

    const handleCategorySelect = (category) => {
        setSelectedCategory(category);
        if (onCategorySelect) {
            onCategorySelect(category);
            navigate('/');
        }
    };

    return (
        <Navbar className="StyledNavbar">
            <Nav.Link href="/">FunLanguageZone</Nav.Link>
            <NavDropdown title={selectedCategory}>
                {categories.map(category => (
                    <NavDropdown.Item key={category} onClick={() => handleCategorySelect(category)}>
                        {category}
                    </NavDropdown.Item>
                ))}
            </NavDropdown>
        </Navbar>
    );
};

export default NavBar;
