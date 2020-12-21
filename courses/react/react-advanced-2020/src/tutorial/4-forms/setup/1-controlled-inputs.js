import React, { useState } from 'react';
// JS
// const input = document.getElementById('myText');
// const inputValue = input.value
// React
// value, onChange

const ControlledInputs = () => {

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log('hello world');
  };

  return <>
    <article>
      <form className="form" onSubmit={handleSubmit}>
        <div className="form-control">
          <label style={{"color": "black"}} htmlFor="firstName">Name: </label>
          <input type="text" id="firstName" name="firstName"/>
        </div>
        <div className="form-control">
          <label style={{"color": "black"}} htmlFor="email">E-mail: </label>
          <input type="text" id="email" name="email"/>
        </div>
        <button type="submit">Add person</button>
      </form>
    </article>
  </>;
};

export default ControlledInputs;
