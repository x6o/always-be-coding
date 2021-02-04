import * as reducerActions from './actions'

const reducer = (state, action) => {
  switch(action.type) {
    case reducerActions.SET_LOADING:
      return {...state, isLoading: true}
    case reducerActions.SET_STORIES:
      const payload = action.payload;
      return {...state, isLoading: false, hits: payload.hits, nbPages: payload.nbPages}
    case reducerActions.REMOVE_STORY:
      return {...state, hits: state.hits.filter(p => p.objectID !== action.payload)}
    case reducerActions.HANDLE_SEARCH:
      return {...state, query: action.payload, page: 0}
    case reducerActions.HANDLE_PAGE:
      if (action.payload === 'inc') {
        let nextPage = state.page + 1;
        if (nextPage > state.nbPages - 1) {
          nextPage = 0;
        }
        return {...state, page: nextPage}
      }
      if (action.payload === 'dec') {
        let prevPage = state.page - 1;
        if (prevPage < 0) {
          prevPage = state.nbPages - 1;
        }
        return {...state, page: prevPage}
      }
      break;
    default:
      throw new Error(`No action matched for "${action.type}" action type.`)
  }
}
export default reducer
