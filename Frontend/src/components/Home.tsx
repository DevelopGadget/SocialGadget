import React from 'react';

const Home: React.FC = (props) => {
    return (
        <div className="container-fluid d-flex -h-100 flex-column px-0 mx-0">
            <div className="row">
                <div className="col">
                    <nav className="navbar fixed-top navbar-light bg-dark">
                        <a className="navbar-brand text-white" href="#">SocialGadget</a>
                    </nav>
                </div>
                <div className="row fill d-flex">
                    <div className="col portlet-container portlet-dropzone">
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Home;