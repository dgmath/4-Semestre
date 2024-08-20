import React from "react";

import MainContent from "../components/MainContent/MainContent";

import Container from "../components/Container/Container";

import { ButtonIconEdit, ButtonNew } from "../components/Button/Button";

import pencil from '../assets/icons/VectorIconeBranco.svg'

import cancel from '../assets/icons/Vector.svg'
import { InputList } from "../components/Input/Input";

const HomePage = () => {
    return (
            <MainContent>
                <Container>
                    <InputList/>
                </Container>
                    <ButtonNew/>
            </MainContent>
    );

}

export default HomePage;