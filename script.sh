#! /bin/bash
# To run: bash script.sh  
echo "<div>" >> README.md
echo "	<div>" >> README.md
echo "		<img src="https://raw.githubusercontent.com/Byron2016/00_forImages/main/images/Logo_01_00.png" align="left" alt="MyLogo" width="200">" >> README.md
echo "	</div>" >> README.md
echo "	&nbsp;" >> README.md
echo "	<div>" >> README.md
echo "		<h1>070_00_CSharpCompClientServer</h1>" >> README.md
echo "	</div>" >> README.md
echo "</div>" >> README.md
echo "" >> README.md
echo "&nbsp;" >> README.md
echo "" >> README.md
echo "## Project Description" >> README.md
echo "" >> README.md
echo "## Steps" >> README.md
echo "" >> README.md

git init
git add .
git commit -m "chore: first commit"
git branch -M main
git remote add origin https://github.com/Byron2016/070_00_CSharpCompClientServer.git
git push -u origin main