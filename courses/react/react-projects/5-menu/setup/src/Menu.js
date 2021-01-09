import React from 'react';

const boldString = (string, substr) => string.replace(RegExp(substr, 'g'), `<b style="background-color: yellow;">${substr}</b>`);

const Menu = ({items, searchText}) => {
  return <div className="section-center">
    {
    items.length > 0 ? items.map((menuItem) => {
      const {id, title, img, desc, price} = menuItem;
      let formattedTitle = "";
      if (searchText) {
        const index = title.indexOf(searchText);
        formattedTitle = boldString(title, searchText);
      }
      return <article key={id} className="menu-item">
          <img src={img} alt={title} className="photo"/>
          <div className="item-info">
            <header>
              <div dangerouslySetInnerHTML={{__html: formattedTitle || title}}></div>
              <h4 className="price">{price}</h4>
            </header>
            <p className="item-text">{desc}</p>
          </div>
      </article>
    }) : "No results..."}
  </div>
};

export default Menu;
