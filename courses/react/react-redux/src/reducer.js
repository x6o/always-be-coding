import reduxActions from './actions'

// reducer - fn to update store
const reducer = (state, action) => {
    if (action.type === reduxActions.CLEAR_CART) {
        return { ...state, cart: [] }
    }
    if (action.type === reduxActions.DECREASE) {
        return { ...state, amount: state.amount - 1 }
    }
    if (action.type === reduxActions.INCREASE) {
        return { ...state, amount: state.amount + 1 }
    }
    if (action.type === reduxActions.REMOVE) {
        return { ...state, cart: state.cart.filter((item) => 
            item.id !== action.payload.id)}
    }
    return state;
};

export default reducer;