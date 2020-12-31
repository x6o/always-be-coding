import React from 'react'
import PropTypes from 'prop-types'

const TestComponent = props => {
    return (
        <div>
            Hello React World!
        </div>
    )
}

TestComponent.propTypes = {
    SomeVar: PropTypes.array.isRequired,
}

export default TestComponent
