import React from 'react';

const Loading = () => {
  return (
    <>
      <div className="title">
        <h2>Our Tours</h2>
        <div className="underline"></div>
      </div>
      <div className="loading">
        <div class="spinner">
          <div class="cube1"></div>
          <div class="cube2"></div>
        </div>
      </div>
    </>
  );
};

export default Loading;
