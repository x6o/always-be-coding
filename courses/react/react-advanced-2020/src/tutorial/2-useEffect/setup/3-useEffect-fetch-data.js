import React, { useState, useEffect } from 'react';

const url = 'https://api.github.com/users';

// second argument
const UseEffectFetchData = () => {
  const [users, setUsers] = useState([]);

  const getUsers = async() => {
    const response = await fetch(url);
    const users = await response.json();
    setUsers(users);
  }

  useEffect(() => {
    getUsers();
  }, []);


  return <>
    <h3>Github users</h3>
    <ul>
      {
        users.map((user) => {
          return <li>{user.login}</li>
        })
      }
    </ul>
  </>;
};

export default UseEffectFetchData;
