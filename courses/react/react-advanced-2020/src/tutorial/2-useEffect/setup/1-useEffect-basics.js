import React, { useState, useEffect } from 'react';
// by default runs after every re-render
// cleanup function
// second parameter
const UseEffectBasics = () => {
  const [value, setValue] = useState(0);
  
  // We can have as many useEffects as we want
  useEffect(() => {
    console.log('Hello World!')
  }, []); // Having an empty array only runs the effect once at the initial render

  useEffect(() => {
    console.log('use effect');
    if (value > 0) {
      document.title = `(${value}) new messages`;
    }
  },[value]); // This use effect will trigger when 'value' is changed

  console.log('render component');
  return <>
    <h1>{value}</h1>
    <button className="btn" onClick={() => setValue( value + 1)}>Change</button>
  </>;
};

export default UseEffectBasics;
