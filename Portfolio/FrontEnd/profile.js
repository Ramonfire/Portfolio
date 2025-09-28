// Fetch and display profile data in a tech portfolio style, hiding IDs
fetch('/omarZaida')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            
            document.getElementById('profile-container').innerHTML = '<p>No profile found.</p>';
            return;
        }
        const profile = data[0];
       
        // Hide Id
        const { Id, ...displayProfile } = profile;

        let html = `
            <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="row">
                        <div class="col-md-3 text-center">
                            <img src="me.png" class="img-fluid  mb-3" alt="Profile Photo" style="max-width:150px;">
                        </div>
                        <div class="col-md-9">
                            <h2 class="card-title">${displayProfile.name}</h2>
                            <h5 class="text-muted">Birthday: ${displayProfile.birthDay}</h5>
                            <p>${displayProfile.aboutme}</p>
                            <ul class="list-unstyled">
                                <li><strong>Email:</strong><a href="mailto:${displayProfile.email}" target="_blank">${displayProfile.email}</a></li>
                                <li><strong>GitHub:</strong> <a href="${displayProfile.gitHub}" target="_blank">${displayProfile.gitHub}</a></li>
                                <li><strong>LinkedIn:</strong> <a href="${displayProfile.linkedIn}" target="_blank">${displayProfile.linkedIn}</a></li>
                            </ul>
                        </div>
                    </div>  
                </div>
            </div>
        `;
        document.getElementById('profile-container').innerHTML = html;
        
    })
    .catch(() => {
        document.getElementById('profile-container').innerHTML = '<p class="text-danger">Failed to load profile.</p>';
    });