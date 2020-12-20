import React, { useState, useEffect } from 'react';
const url = 'https://api.github.com/users/x6o';
const MultipleReturns = () => {
  const [isLoading, setIsLoading] = useState(true);
  const [isError, setIsError] = useState(false);
  const [user, setUser] = useState({});

  useEffect(()=> {
    fetch(url)
    .then((resp)=> {
      if(resp.status >= 200 && resp.status <= 299) {
        return resp.json()
      }
      else {
        setIsLoading(false)
        setIsError(true)
        throw new Error(resp.statusText);
      }
    })
    .then((user) => {
      const {login, avatar_url} = user;
      setUser({login, avatar_url})
      setIsLoading(false)
      console.log('user', user)
    }) 
    .catch(error=>console.log('error', error));
  }, []);

  if (isLoading) {
    return <img src="/ajax-loader.gif" alt="Loading..."/>
  }
  if (isError) {
    return <h2>Error...</h2>
  }
  return <div>
    <img src={user.avatar_url} alt={user.login} />
    <h2>{user.login}</h2>
  </div>;
};

export default MultipleReturns;
