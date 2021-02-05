import reduxActions from './actions'

// reducer - fn to update store
const reducer = (state, action) => {
    if (action.type === reduxActions.DECREASE) {
        return { ...state, count: state.count - 1 }
    }
    return state;
};

export default reducer;