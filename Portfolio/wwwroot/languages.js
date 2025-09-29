// Map languages to their emoji flags
const languageFlags = {
    English: 'https://flagcdn.com/16x12/gb.png',
    French: 'https://flagcdn.com/16x12/fr.png',
    Spanish: 'https://flagcdn.com/16x12/es.png',
    German: 'https://flagcdn.com/16x12/de.png',
    Arabic: 'https://flagcdn.com/16x12/sa.png',
    Japanese: 'https://flagcdn.com/16x12/jp.png'
};

// Fetch and display mastered languages, hiding IDs
fetch('/omarZaida/masteredlanguages')
    .then(res => res.json())
    .then(data => {
        if (!data || data.length === 0) {
            document.getElementById('languages-container').innerHTML = '<p>No languages found.</p>';
            return;
        }
        let html = '<div class="row">';
        data.forEach(lang => {
            const { Id, language, level } = lang;

            let levelText = '';
            switch (level) {
                case 3: levelText = 'Native'; break;
                case 2: levelText = 'Professional'; break;
                case 1: levelText = 'Basics'; break;
                case 0: default: levelText = 'None'; break;
            }

            const flag = languageFlags[language] || '🏳️'; // default flag if not found

            html += `
                <div class="col-md-4 mb-3">
                    <div class="card h-100">
                        <div class="card-body">
                            <h5 class="card-title">
                                <img src="${languageFlags[language]}" alt="${language} flag" style="width:20px; height:14px; margin-right:5px;">
                                ${language}
                             </h5>
                            <p class="card-text">Level: ${levelText}</p>
                        </div>
                    </div>
                </div>
            `;
        });
        html += '</div>';
        document.getElementById('languages-container').innerHTML = html;
    })
    .catch(() => {
        document.getElementById('languages-container').innerHTML = '<p class="text-danger">Failed to load languages.</p>';
    });
