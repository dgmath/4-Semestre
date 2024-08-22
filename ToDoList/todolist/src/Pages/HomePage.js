import React, { useState } from "react";

import MainContent from "../components/MainContent/MainContent";

import Container from "../components/Container/Container";

import { ButtonIconEdit, ButtonNew } from "../components/Button/Button";

import pencil from '../assets/icons/VectorIconeBranco.svg'

import cancel from '../assets/icons/Vector.svg'
import { InputList } from "../components/Input/Input";
import { List } from "../components/List/List";
import { Title } from "../components/Title/Title";
import { InputSearch } from "../components/InputSearch/InputSearch";




const HomePage = () => {
    const [tasks, setTasks] = useState([{name: 'oi', done: true}, {name: 'Math', done: false}]);

    const NewTask = (name) => {
        setTasks([...tasks, { name, done: false }]);
    };

    const handleCheckTest = (index) => {
        const newCheckTask = [...tasks];
        newCheckTask[index].done = !newCheckTask[index].done;
        setTasks(newCheckTask);
    };
    // const [click, setClick] = useState()


    return (
        <MainContent>
            <Container>
                <Title />
                <InputSearch
                    
                />
                <List item={tasks} prop={tasks} onChange={handleCheckTest} />
            </Container>
            <ButtonNew />
        </MainContent>
    );

}

export default HomePage;