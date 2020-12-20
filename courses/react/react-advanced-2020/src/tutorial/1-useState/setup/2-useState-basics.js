import React, { useState } from 'react';

// Hooks in react start with "use": useState, useEffect...
// Component name must be uppercase for the hook to work
// The hook must be in the function or component body
// Cannot call hook functions condictionally

const UseStateBasics = () => {
  const [text, setText] = useState('Random title');

  const handleClick = () => {
    if (text === 'Random title') {
      setText('Hello World');
    } else {
    setText('Random title');
    }
  };

  return <React.Fragment>
    <h1>{text}</h1>
    <button className="btn" onClick={handleClick}>
      Change Title
    </button>
  </React.Fragment>
};

export default UseStateBasics;
