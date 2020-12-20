import React, { useState } from 'react';

const UseStateCounter = () => {
  const [value, setValue] = useState(0);
  const reset = () => {
    setValue(0);
  }

  const complexIncrease = () => {
    setTimeout(() => {
      // setValue(value + 1);
      setValue((prevState)=>{
        return prevState + 1;
      });
    }, 2000);
  };

  return (
    <>
      <section style={{margin: '4rem 0'}}>
        <h2>Regular Counter</h2>
        <h1>{value}</h1>
        <button className="btn" onClick={() => setValue(value - 1)}>-</button>
        <button className="btn" style={{visibility: value !== 0 ? 'visible' : 'hidden'}}onClick={reset}>reset</button>
        <button className="btn" onClick={() => setValue(value + 1)}>+</button>
      </section>
      <hr/>
      <section style={{margin: '4rem 0'}}>
        <h2>Complex Counter</h2>
        <h1>{value}</h1>
        <button className="btn" onClick={complexIncrease}>increase later</button>
      </section>
    </>
  );
};

export default UseStateCounter;
