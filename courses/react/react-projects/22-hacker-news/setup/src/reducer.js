import * as reducerActions from './actions'

const reducer = (state, action) => {
  switch(action.type) {
    case reducerActions.SET_LOADING:
      return {...state, isLoading: true}
    default:
      throw new Error(`No action matched for "${action.type}" action type.`)
  }
}
export default reducer
