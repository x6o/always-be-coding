import React, { useState, useEffect } from 'react'
import {
  FaEnvelopeOpen,
  FaUser,
  FaCalendarTimes,
  FaMap,
  FaPhone,
  FaLock,
  FaLowVision,
} from 'react-icons/fa'

const url = 'https://randomuser.me/api/'
const defaultImage = 'https://randomuser.me/api/portraits/men/75.jpg'

function App() {
  const [loading, setLoading] = useState(true);
  const [person, setPerson] = useState(null);
  const [title, setTitle] = useState('name')
  const [value, setValue] = useState('random person');
  const [isValueCopied, setIsValueCopied] = useState(false);

  const getPerson = async () => {
    setLoading(true);
    const response = await fetch(url);
    const data = await response.json();
    const person = data.results[0];
    const {phone, email} = person;
    const {large:image} = person.picture;
    const {login: {password}} = person;
    const {first, last} = person.name;
    const {dob:{age}} = person;
    const {street: {number, name}} = person.location;

    const newPerson = {
      image,
      phone,
      email,
      password,
      age,
      street: `${number} ${name}`,
      name: `${first} ${last}`,
    }
    setPerson(newPerson);
    console.log(newPerson);
    setLoading(false);
    setTitle('name');
    setValue(newPerson.name);
  }

  useEffect(() => {
    getPerson();
  }, [])

  useEffect(() => {
    console.log('triggered');
    var timer = setTimeout(() => {
      setIsValueCopied(false);      
    }, 1000);

  }, [isValueCopied])

  const handleValue = (e) => {
    if (e.target.classList.contains('icon')) {
      const newValue = e.target.dataset.label;
      console.log(person[newValue]);
      setValue(person[newValue]);
      setTitle(newValue);
    }
  }

  const handleCopy = () => {
    navigator.clipboard.writeText(value);
    setIsValueCopied(true);
  }

  return <div>
    <div className="block bcg-black">
    </div>
    <div className="block">
      <div className="container">
        <img src={(person && person.image) || defaultImage} 
          alt="random user" 
          className="user-img"/>
        <p className="user-title">my {title} is</p>
        <p className="user-value" onMouseUp={() => handleCopy()}>{value}</p>
        <p>{isValueCopied ? 'value copied!' : 'click to copy'}</p>
        <div className="values-list">
          <button className="icon" data-label="name" onMouseOver={handleValue}><FaUser /></button>
          <button className="icon" data-label="email" onMouseOver={handleValue}><FaEnvelopeOpen /></button>
          <button className="icon" data-label="age" onMouseOver={handleValue}><FaCalendarTimes /></button>
          <button className="icon" data-label="street" onMouseOver={handleValue}><FaMap /></button>
          <button className="icon" data-label="phone" onMouseOver={handleValue}><FaPhone /></button>
          <button className="icon" data-label="password" onMouseOver={handleValue}><FaLock /></button>
        </div>
        <button className="btn" type="button" onClick={getPerson}>
          {loading ? 'loading...' : 'random user'}
        </button>
      </div>
    </div>
    </div>
}

export default App
