import React from 'react';
import './Style.css';

const Container = ( { children } ) => {
    return (
        <div className='container'>
            {children}
        </div>
    );
};

export default Container;