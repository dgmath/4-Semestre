import React from 'react';
import "../MainContent/Style.css";

const MainContent = ( {children} ) => {
    return (
        <main className='main-content'>
           {children}
        </main>
    );
};

export default MainContent;