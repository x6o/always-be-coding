import React, { useState } from 'react';
import {data} from '../../../data';
// more components
// fix - context api, redux (for more complex cases)

const PropDrilling = () => {
  const [people, setPeople] = useState(data);
  const [isReloadBtnVisible, setIsReloadBtnVisible] = useState(false);
  const removePerson = (id) => {
    if (people.length === 1) {
      setIsReloadBtnVisible(true);
    }
    setPeople((people) => {
      return people.filter((person) => person.id !== id);
    })


  }
  return <>
    <section>
      <h3>prop drilling</h3>
      {isReloadBtnVisible ? <button styl onClick={() => setPeople(data)}>Reload data</button> : null}
      <List people={people} removePerson={removePerson} />
    </section>
  </>;
};

const List = ({people, removePerson}) => {
  return (
    <>
      {
        people.map((person) => {
          return <SinglePerson key={person.id} {...person} removePerson={removePerson} />
        })
      }
    </>
  )
}

const SinglePerson = ({id, name, removePerson}) => {
  return <div className="item">
    <h4>{name}</h4>
    <button onClick={()=> removePerson(id)}>Remove</button>
  </div>
}

export default PropDrilling;
