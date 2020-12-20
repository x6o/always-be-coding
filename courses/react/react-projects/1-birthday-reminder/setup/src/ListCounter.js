import React from 'react';

const ListCounter = ({number}) => {
    return (
        number > 0 ? <h3>{number} birthdays today</h3> : <h3>No birthdays!</h3>
    );
}

export default ListCounter;