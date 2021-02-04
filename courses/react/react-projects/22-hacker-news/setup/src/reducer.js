import * as reducerActions from './actions'

const reducer = (state, action) => {
  switch(action.type) {
    case reducerActions.SET_LOADING:
      return {...state, isLoading: true}
    case reducerActions.SET_STORIES:
      const payload = action.payload;
      return {...state, isLoading: false, hits: payload.hits, nbPages: payload.nbPages}
    default:
      throw new Error(`No action matched for "${action.type}" action type.`)
  }
}
export default reducer
