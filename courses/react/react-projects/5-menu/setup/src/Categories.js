import React, { useState } from 'react';

const Categories = ({categories, filterItems, searchItem}) => {
  const [searchText, setSearchText] = useState("");

  const textSearch = (query) => {
      setSearchText(query);
      if(query){
        searchItem(query);
      } else {
        filterItems("all");
      }
  };

  return <>
    <div className="btn-container">
      {categories.map((category, index) => {
        return <button type="button" className="filter-btn" key={index} onClick={() => filterItems(category)}>
          {category}
        </button>
      })}
      <div className="searchbox">
        <input type="text" value={searchText} onChange={(e) => textSearch(e.target.value)} placeholder="Search item..."></input>
      </div>
    </div>
  </>;
};

export default Categories;
