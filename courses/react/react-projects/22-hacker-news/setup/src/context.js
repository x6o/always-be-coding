import React, { useContext, useEffect, useReducer } from 'react'

import * as reducerActions from './actions'

import reducer from './reducer'

const API_ENDPOINT = 'https://hn.algolia.com/api/v1/search?'

const initialState = {
  isLoading: true,
  hits: [],
  query: 'react',
  page: 0,
  nbPages: 0
}

const AppContext = React.createContext()

const AppProvider = ({ children }) => {
  const [state, dispatch] = useReducer(reducer, initialState);

  const fetchStories = async (url) => {
    dispatch({ type: reducerActions.SET_LOADING });
    try {
      const response = await fetch(url);
      const data = await response.json();
      dispatch({
        type: reducerActions.SET_STORIES,
        payload: {
          hits: data.hits,
          nbPages: data.nbPages
        }
      });
      console.log(data);
    } catch (error) {
      console.log(error);
    }
  }

  const removeStory = (id) => {
    dispatch({ type: reducerActions.REMOVE_STORY, payload: id })
  }

  useEffect(() => {
    fetchStories(`${API_ENDPOINT}query=${state.query}&page=${state.page}`);
  }, [state.query, state.page])

  const handleSearch = (query) => {
    dispatch({ type: reducerActions.HANDLE_SEARCH, payload: query });
  }

  const handlePage = (value) => {
    dispatch({type: reducerActions.HANDLE_PAGE, payload: value})
  }
  return <AppContext.Provider
    value={{ ...state, removeStory, handleSearch, handlePage }}>
    {children}
  </AppContext.Provider>
}
// make sure use
export const useGlobalContext = () => {
  return useContext(AppContext)
}

export { AppContext, AppProvider }
