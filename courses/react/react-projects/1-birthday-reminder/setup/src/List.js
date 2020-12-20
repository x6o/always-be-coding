import React from 'react';
import ListCounter from './ListCounter';

const List = ({people}) => {
  const [peeps, setPeeps] = React.useState(people);
  const removeHandler = (id) => {
    setPeeps((oldPeeps) => {
      let newPeeps = oldPeeps.filter((peep) => peep.id !== id );
      return newPeeps
    })
  };

  return (
    <>
      <ListCounter number={peeps.length} />
      {peeps.map((person) => {
        const {id, name, age, image} = person;
        return (
        <>
          <article key={id} className="person">
            <img src={image} alt={name}/>
            <div>
              <h4>{name}</h4>
              <p>{age} years</p>
              <a href="#" onClick={()=>removeHandler(id)}>remove</a>
            </div>
          </article>

        </>
        )
      })}
      <button style={{display: peeps.length > 0 ? 'block':'none'}} onClick={()=>setPeeps([])}>Dismiss {peeps.length > 1 ? "all":"one"}</button>
    </>
  );
};

export default List;
