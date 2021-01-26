import React, { useState, useEffect } from 'react'
import { useFetch } from './useFetch'
import Follower from './Follower'
function App() {
  const {loading, data} = useFetch();
  const [page, setPage] = useState(0);
  const [followers, setFollowers] = useState([]);

  useEffect(() => {
    if(loading) return
    setFollowers(data[page]);
  }, [loading,page]);

  const handlePage = (index) => {
    setPage(index);
  }

  const prevPage = () => {
    setPage((currentPage) => {
      let prevPage = currentPage - 1;
      if (prevPage < 0) {
        prevPage = data.length -1 ;
      }
      return prevPage;
    })
  }

  const nextPage = () => {
    setPage((currentPage) => {
      let nextPage = currentPage + 1;
      if (nextPage > data.length - 1) {
        nextPage = 0;
      }
      return nextPage;
    })
  }

  return <main>
    <div className="section-title">
      <h1>{loading ? 'Loading...' : 'pagination'}</h1>
    </div>
    <section className="followers">
      <div className="container">
        {
          followers.map((follower) => {
            return <Follower key={follower.id} {...follower} />
          })
        }
      </div>
      {
        !loading && (<div className="btn-container">
          <buttton className="prev-btn" onClick={prevPage}>
            Prev
          </buttton>
          {
            data.map((item, index) => {
              return <button key={index} 
              className={`page-btn ${index === page ? 'active-btn' : null}`}
              onClick={() => handlePage(index)}>
                {index + 1}
              </button>
            })
          }
          <buttton className="next-btn" onClick={nextPage}>
            Next
          </buttton>
        </div>)
      }
      
    </section>
  </main>
}

export default App
