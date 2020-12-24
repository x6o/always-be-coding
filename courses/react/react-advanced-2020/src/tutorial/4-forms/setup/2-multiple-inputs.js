import React, { useState } from 'react';
// JS
// const input = document.getElementById('myText');
// const inputValue = input.value
// React
// value, onChange
// dynamic object keys

const ControlledInputs = () => {
  // const [firstName, setFirstName] = useState('');
  // const [email, setEmail] = useState('');
  // const [age, setAge] = useState('');

  // instead of the individual fields we can use an object
  const [person, setPerson] = useState({
    firstName:'',
    email:'',
    age:''
  });

  const [people, setPeople] = useState([]);

  const handleChange = (e) => {
    const name = e.target.name;
    const value = e.target.value;

    // dinamically map the name of the field to the name of property inside the object
    setPerson({...person, [name]:value});
  }

  const handleSubmit = (e) => {
    e.preventDefault();

    if(person.firstName && person.email && person.age) {
      const newPerson = {...person, id: new Date().getTime().toString() };
      
      setPeople([...people, newPerson]);
      setPerson({firstName:'', email:'', age:''});
    }
  }


  return (
    <>
      <article>
        <form className='form' style={{'color': 'black'}}>
          <div className='form-control'>
            <label htmlFor='firstName'>Name : </label>
            <input
              type='text'
              id='firstName'
              name='firstName'
              value={person.firstName}
              onChange={handleChange}
            />
          </div>
          <div className='form-control'>
            <label htmlFor='email'>Email : </label>
            <input
              type='email'
              id='email'
              name='email'
              value={person.email}
              onChange={handleChange}
            />
          </div>
          <div className='form-control'>
            <label htmlFor='age'>Age : </label>
            <input
              type='text'
              id='age'
              name='age'
              value={person.age}
              onChange={handleChange}
            />
          </div>
          <button type='submit' onClick={handleSubmit}>add person</button>
        </form>
        {
          people.map((person, index) => {
            const { id, firstName, email, age} = person;
            return (
              <div className='item' style={{'color':'black'}} key={id}>
                <h4>{firstName}</h4>
                <p>{email}</p>
                <p>{age} y.o</p>
              </div>
            );
          })
        }
      </article>
    </>
  );
};

export default ControlledInputs;
