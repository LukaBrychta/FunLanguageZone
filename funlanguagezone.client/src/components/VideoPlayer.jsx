import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { Row, Col, Container } from 'react-bootstrap';
import './VideoPlayer.css';

const VideoPlayer = () => {
    const { id } = useParams();
    const [video, setVideo] = useState(null);
    const [lyrics, setLyrics] = useState('');

    useEffect(() => {
        const fetchVideo = async () => {
            const response = await fetch(`/api/video/${id}`);
            if (response.ok) {
                const data = await response.json();
                setVideo(data);
            }
        };

        fetchVideo();
    }, [id]);

    useEffect(() => {
        const fetchLyrics = async () => {
            const response = await fetch(`https://api.lyrics.ovh/v1/${video.artist}/${video.title}`);
            if (response.ok) {
                const data = await response.json();
                setLyrics(data.lyrics);
            }
        };

        fetchLyrics();
    }, [video]);

    if (!video) return <div>Loading...</div>;

    return (
        <Container>
            <h1>{video.title}</h1>
            <h2>{video.artist}</h2>
            <p>{video.genres.join(', ')}</p>
            <Row>
                <Col xs={12} md={6} lg={6}>
                    <div className="video-container">
                        <iframe
                            title={video.title}
                            src={`https://www.youtube.com/embed/${video.youtubeId}`}
                            allow="accelerometer; clipboard-write; encrypted-media; gyroscope"
                            allowFullScreen
                        ></iframe>
                    </div>
                </Col>
                <Col className="lyrics-container" xs={12} md={6} lg={6}>
                    <pre style={{ whiteSpace: 'pre-wrap', wordWrap: 'break-word', fontFamily: 'Inter, system-ui, Avenir, Helvetica, Arial, sans-serif' }}>{lyrics}</pre>
                </Col>
            </Row>
        </Container>
    );
};

export default VideoPlayer;
