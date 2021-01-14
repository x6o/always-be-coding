import React, { useState, useEffect } from 'react'
import List from './List'
import Alert from './Alert'
import Logo from './logo.png'

const getLocalStorage = () => {
  let list = localStorage.getItem('list');
  if (list) {
    return JSON.parse(localStorage.getItem('list'))
  } else {
    return []
  }
}

function App() {
  const [name, setName] = useState('');
  const [list, setList] = useState(getLocalStorage());
  const [isEditing, setIsEditing] = useState(false);
  const [editId, setEditId] = useState(null);
  const [alert, setAlert] = useState({show: false, msg: '', type: ''});

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!name) {
      showAlert(true, 'danger', 'please enter value');
    }
    else if (name && isEditing)
    {
      setList(list.map((item)=>{
        if (item.id == editId) {
          return {...item, title: name}
        }
        return item
      }));
      setName('');
      setEditId(null);
      setIsEditing(false);
      showAlert(true, 'success', 'value changed');
    }
    else if(itemExists(list, name))
    {
      showAlert(true, 'danger', 'item already in list');
    }
    else
    {
      showAlert(true, 'success', 'item added to the list');
      const newItem = {
        id: new Date().getTime().toString(),
        title: name,
      }
      setList([...list, newItem]);
      setName('');
    }
  }

  const itemExists = (list, name) => {
    let itemFound = list.find((item) => item.title === name);

    if (itemFound){
      return true
    } else {
      return false
    }
  }

  const showAlert = (show=false, type="", msg="") => {
    setAlert({show, type, msg});
  }

  const clearList = () => {
    showAlert(true, 'danger', 'removed all items from list');
    setList([]);
  }

  const removeItem = (id) => {
    showAlert(true, 'danger', 'item removed');
    setList(list.filter((item) => item.id !== id));
  }

  const editItem = (id) => {
    const specificItem = list.find((item) => item.id === id);
    setIsEditing(true);
    setEditId(id);
    setName(specificItem.title);
  }

  useEffect(() => {
    localStorage.setItem('list', JSON.stringify(list));
  }, [list])

  return <section className="section-center">
    <img src={Logo} alt="Grocery Buddy" />
    <form className="grocery-form" onSubmit={handleSubmit}>
      {alert.show && <Alert {...alert}  removeAlert={showAlert} list={list} />}
      <h3>grocery buddy</h3>
      <div className="form-control">
        <input type="text" 
        className="grocery" 
        placeholder="e.g. eggs"
        value={name}
        onChange={(e) => setName(e.target.value)}
        />
        <button type="submit" className="submit-btn">
          {isEditing ? 'edit' : 'add'}
        </button>
      </div>
    </form>
    {
      list.length > 0 && (
        <div className="grocery-container">
          <List items={list} removeItem={removeItem} editItem={editItem} />
          <button className="clear-btn" onClick={clearList}>clear items</button>
        </div>
      )
    }
    {
      list.length === 0 && (
        <p className="grocery-empty-container">No grocery items... yet!</p>
      )
    }
  </section>
}

export default App
