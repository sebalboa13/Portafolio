# Generated by Django 3.1.3 on 2021-10-28 22:15

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0014_auto_20211028_1832'),
    ]

    operations = [
        migrations.AlterField(
            model_name='facturaxxi',
            name='media',
            field=models.FileField(null=True, upload_to=''),
        ),
    ]
