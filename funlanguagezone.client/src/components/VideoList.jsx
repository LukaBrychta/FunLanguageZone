import React, { useEffect, useState } from 'react';
import { Row, Col, Container } from 'react-bootstrap';
import VideoThumbnail from './VideoThumbnail';

const VideoList = ({ selectedCategory }) => {
    const [videos, setVideos] = useState([]);

    useEffect(() => {
        async function fetchVideos() {
            const response = await fetch('/api/videos');
            if (response.ok) {
                const data = await response.json();
                if (Array.isArray(data)) {
                    const sortedData = data.sort((a, b) => a.title.localeCompare(b.title));
                    setVideos(sortedData);
                }
            }
        }
        fetchVideos();
    }, []);

    const filteredVideos = selectedCategory
        ? videos.filter(video => video.genres.includes(selectedCategory))
        : videos;

    return (
        <Container>
            <Row>
                {Array.isArray(filteredVideos) && filteredVideos.length > 0 ? (
                    filteredVideos.map(video => (
                        <Col key={video.id} xs={6} md={4} lg={3}>
                            <VideoThumbnail video={video} />
                        </Col>
                    ))
                ) : (
                    <p>No videos available. Try refreshing the page.</p>
                )}
            </Row>
        </Container>
    );
};

export default VideoList;
