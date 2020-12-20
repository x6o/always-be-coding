import React, { useState } from 'react';

const UseStateObject = () => {
  const [person, setPerson] = useState({name:'Peter',age:24,message:'Random message'});
  
  const changeMessage = () => {
    //setPerson({...person, message: 'hello world'});
    
    setMessage('My message');
  }

  const [name, setName] = useState('Peter');
  const [age, setAge] = useState(24);
  const [message, setMessage] = useState('Random message');

  return (
    <>
      <h3>{name}</h3>
      <h3>{age}</h3>
      <h3>{message}</h3>
      <button className="btn" onClick={changeMessage}>Change Message</button>
    </>
  );
};

export default UseStateObject;
