import React, { useState } from 'react';
import Menu from './Menu';
import Categories from './Categories';
import items from './data';

const allCategories = ['all', ...new Set(items.map((item) => item.category)) ] 

function App() {
  const [menuItems, setMenuItems] = useState(items);
  const [categories, setCategories] = useState(allCategories);
  const [searchText, setSearchText] = useState("");

  const filterItems = (category) => {
    if(category==="all") {
      setMenuItems(items);
      return;
    }
    const newItems = items.filter((item) => item.category === category);

    setMenuItems(newItems);
  }

  const searchItem = (query) => {
    if(!query) {
      setMenuItems(items);
      setSearchText("");
      return;
    }
    const newItems = items.filter((item) => item.title.toLowerCase().includes(query.toLowerCase()));
    setSearchText(query);

    setMenuItems(newItems);
  }

  return <main>
    <section className="menu section">
      <div className="title">
        <h2>Our menu</h2>
        <div className="underline"></div>
      </div>
      <Categories categories={categories} filterItems={filterItems} searchItem={searchItem}/>
      <Menu items={menuItems} searchText={searchText} />
    </section>
  </main>;
}

export default App;
